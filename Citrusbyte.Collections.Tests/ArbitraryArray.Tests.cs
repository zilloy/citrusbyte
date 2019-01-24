using System;
using System.Collections.Generic;
using Xunit;

namespace Citrusbyte.Collections.Tests
{
    public class ArbitraryArrayTests
    {
        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] {
                new ArbitraryArray()
                        .Add(new ArbitraryArray()
                                .Add(1)
                                .Add(2)
                                .Add(new ArbitraryArray()
                                        .Add(3)))
                        .Add(4),

                new [] {1,2,3,4}
            },

            new object[] {
                new ArbitraryArray()
                        .Add(new ArbitraryArray()
                                .Add(1)
                                .Add(2)
                                .Add(new ArbitraryArray()
                                        .Add(3)
                                        .Add(new ArbitraryArray()
                                                .Add(4)
                                                .Add(5)
                                                .Add(new ArbitraryArray()
                                                        .Add(6)
                                                    )
                                            )
                                    )
                            )
                        .Add(7),

                new [] {1,2,3,4,5,6,7}
            },

            new object[] {
                new ArbitraryArray()
                        .Add(1)
                        .Add(2)
                        .Add(3)
                        .Add(4),
                new [] {1,2,3,4}
            },

            new object[] {
                new ArbitraryArray(),
                new int[] {}
            },

        };

        [Theory]
        [MemberData(nameof(Data))]
        public void Flattens_To_Array(ArbitraryArray arbitraryArray, int[] expected)
        {
            Assert.Equal(expected, arbitraryArray.Flatten());
        }

        [Fact]
        public void Add_Throws_Exception_Null_Argument()
        {
            Assert.Throws<ArgumentNullException>(() => new ArbitraryArray().Add(null));
        }
    }
}
