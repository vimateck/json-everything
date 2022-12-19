﻿using System.Text.Json.Nodes;
using Json.More;

namespace Json.Path.Expressions;

internal class DivideOperator : IBinaryValueOperator
{
	public JsonNode? Evaluate(JsonNode? left, JsonNode? right)
	{
		if (left is not JsonValue lValue ||
		    right is not JsonValue rValue)
			return null;

		var rNumber = rValue.GetNumber();

		return rNumber is null or 0 ? null : lValue.GetNumber() / rNumber;
	}
}