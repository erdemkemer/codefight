using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Xunit;

namespace CodeFight.Tests
{
    public class isCryptSolutionSpecs
    {

        [Fact]
        void should_true_for_send_more_money()
        {
            var crypt = new[] {"SEND", "MORE", "MONEY"};
            var solution = new char[][]
            {
                new[] {'O', '0'},
                new[] {'M', '1'},
                new[] {'Y', '2'},
                new[] {'E', '5'},
                new[] {'N', '6'},
                new[] {'D', '7'},
                new[] {'R', '8'},
                new[] {'S', '9'}
            };

            new IsCryptSolution().isCryptSolution(crypt,solution).Should().BeTrue();
        }

        [Fact]
        void should_true_for_send_more_big_money()
        {
            var crypt = new[] { "AAAAAAAAAAAAA", "AAAAAAAAAAAAA", "CBBBBBBBBBBBBD" };
            var solution = new char[][]
            {
                new[] {'A', '6'},
                new[] {'D', '2'},
                new[] {'B', '3'},
                new[] {'C', '1'}
            };
            

            new IsCryptSolution().isCryptSolution(crypt, solution).Should().BeTrue();
        }

        [Fact]
        void should_true_for_edge_case()
        {
            var crypt = new[] { "WASD", "IJKL", "AOPAS" };
            var solution = new char[][]
            {
                new[]{'W', '2'},
                new[]{'A', '0'},
                new[]{'S', '4'},
                new[]{'D', '1'},
                new[]{'I', '5'},
                new[]{'J', '8'},
                new[]{'K', '6'},
                new[]{'L', '3'},
                new[]{'O', '7'},
                new[]{'P', '9'}
            };
            

            new IsCryptSolution().isCryptSolution(crypt, solution).Should().BeFalse();
        }
    }
}
