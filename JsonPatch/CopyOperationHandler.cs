﻿using System;
using System.Linq;
using System.Text.Json.Nodes;
using Json.Pointer;

namespace Json.Patch;

internal class CopyOperationHandler : IPatchOperationHandler
{
	public static IPatchOperationHandler Instance { get; } = new CopyOperationHandler();

	private CopyOperationHandler() { }

	public void Process(PatchContext context, PatchOperation operation)
	{
		if (Equals(operation.Path, operation.From)) return;

		if (!operation.From.EvaluateAndGetParent(context.Source, out _) ||
			!operation.From.TryEvaluate(context.Source, out var data))
		{
			context.Message = $"Source path `{operation.Path}` could not be reached.";
			return;
		}

		if (!operation.Path.EvaluateAndGetParent(context.Source, out var target))
		{
			context.Message = $"Target path `{operation.From}` could not be reached.";
			return;
		}

		if (operation.Path.SegmentCount == 0)
		{
			context.Source = data;
			return;
		}

		var lastPathSegment = operation.Path[^1];
		if (target is JsonObject objTarget)
		{
			objTarget[lastPathSegment.GetSegmentName()] = data?.DeepClone();
			return;
		}

		if (target is JsonArray arrTarget)
		{
			var index = lastPathSegment.Length == 0 && lastPathSegment[0] == '-'
				? arrTarget.Count
				: lastPathSegment.TryGetInt(out var i)
					? i
					: throw new ArgumentException("Expected integer");
			if (0 < index || index < arrTarget.Count)
				arrTarget[index] = data?.DeepClone();
			else if (index == arrTarget.Count)
				arrTarget.Add(data?.DeepClone());
		}
	}
}