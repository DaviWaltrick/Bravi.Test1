using Bravi.Test1;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class StringBracketValidationsTest
    {
        [TestMethod]
        public void IsValidBracketExpression_Should_Return_True_When_Opening_And_Closing_Curly_Brackets_Are_In_The_Correct_Order()
        {
            string testString = "{}";
            testString.IsValidBracketExpression().Should().BeTrue();
        }

        [TestMethod]
        public void IsValidBracketExpression_Should_Return_True_When_Opening_And_Closing_Square_Brackets_Are_In_The_Correct_Order()
        {
            string testString = "[]";
            testString.IsValidBracketExpression().Should().BeTrue();
        }

        [TestMethod]
        public void IsValidBracketExpression_Should_Return_True_When_Opening_And_Closing_Parenthesis_Are_In_The_Correct_Order()
        {
            string testString = "()";
            testString.IsValidBracketExpression().Should().BeTrue();
        }

        [TestMethod]
        public void IsValidBracketExpression_Should_Return_True_When_There_Are_Different_Opening_And_Closing_Brackets_In_The_Correct_Order()
        {
            string testString = "()[]{}";
            testString.IsValidBracketExpression().Should().BeTrue();
        }

        [TestMethod]
        public void IsValidBracketExpression_Should_Return_True_When_There_Are_Nested_Opening_And_Closing_Brackets_In_The_Correct_Order()
        {
            string testString = "{([])}";
            testString.IsValidBracketExpression().Should().BeTrue();
        }

        [TestMethod]
        public void IsValidBracketExpression_Should_Return_False_When_There_Are_Nested_Brackets_Closed_In_The_Wrong_Order()
        {
            string testString = "{([)}]";
            testString.IsValidBracketExpression().Should().BeFalse();
        }

        [TestMethod]
        public void IsValidBracketExpression_Should_Return_False_When_There_Are_Closing_Brackets_Without_Opening_Brackets()
        {
            string testString = ")";
            testString.IsValidBracketExpression().Should().BeFalse();
        }

        [TestMethod]
        public void IsValidBracketExpression_Should_Return_False_When_There_Are_Opening_Brackets_Without_Closing_Brackets()
        {
            string testString = "(";
            testString.IsValidBracketExpression().Should().BeFalse();
        }

        [TestMethod]
        public void IsValidBracketExpression_Should_Return_False_When_There_Are_Opening_And_Closing_Brackets_In_The_Wrong_Order()
        {
            string testString = ")(";
            testString.IsValidBracketExpression().Should().BeFalse();
        }

        [TestMethod]
        public void IsValidBracketExpression_Should_Return_False_When_There_Is_An_Opening_Bracket_With_The_Wrong_Closing_Bracket()
        {
            string testString = "(]";
            testString.IsValidBracketExpression().Should().BeFalse();
        }
    }
}
