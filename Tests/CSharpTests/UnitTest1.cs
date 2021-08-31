using System;
using Xunit;

namespace CSharpTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestFSharp1()
        {
            var succ = NaiveSharpEval.Executor.ExecuteFSharp("1 + 2", out var res);
            Assert.True(succ);
            Assert.Equal("3", res);
        }

        [Fact]
        public void TestFSharp2()
        {
            var succ = NaiveSharpEval.Executor.ExecuteFSharp(@"
let add a b = a + b
add 10 11", out var res);
            Assert.True(succ);
            Assert.Equal("21", res);
        }

        [Fact]
        public void TestCSharp1()
        {
            var succ = NaiveSharpEval.Executor.ExecuteCSharp("1 + 2", out var res);
            Assert.True(succ);
            Assert.Equal("3", res);
        }

        [Fact]
        public void TestCSharp2()
        {
            var succ = NaiveSharpEval.Executor.ExecuteCSharp(@"
Func<int, int, int> add = (a, b) => a + b;
add(10, 11)", out var res);
            Assert.True(succ);
            Assert.Equal("21", res);
        }
    }
}
