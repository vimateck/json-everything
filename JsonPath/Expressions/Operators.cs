﻿namespace Json.Path.Expressions;

internal static class Operators
{
	public static readonly IBinaryValueOperator Add = new AddOperator();
	public static readonly IBinaryValueOperator Subtract = new SubtractOperator();
	public static readonly IBinaryValueOperator Multiply = new MultiplyOperator();
	public static readonly IBinaryValueOperator Divide = new DivideOperator();

	public static readonly IBinaryComparativeOperator EqualTo = new EqualToOperator();
	public static readonly IBinaryComparativeOperator NotEqualTo = new NotEqualToOperator();
	public static readonly IBinaryComparativeOperator LessThan = new LessThanOperator();
	public static readonly IBinaryComparativeOperator LessThanOrEqualTo = new LessThanOrEqualToOperator();
	public static readonly IBinaryComparativeOperator GreaterThan = new GreaterThanOperator();
	public static readonly IBinaryComparativeOperator GreaterThanOrEqualTo = new GreaterThanOrEqualToOperator();

	public static readonly IBinaryLogicalOperator And = new AndOperator();
	public static readonly IBinaryLogicalOperator Or = new OrOperator();
	public static readonly IUnaryLogicalOperator Not = new NotOperator();
}