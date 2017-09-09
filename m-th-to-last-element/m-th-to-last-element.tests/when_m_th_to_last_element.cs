using System;
using NUnit.Framework;
using NUnit.Runner;
using m_th_to_last_element;

namespace m_th_to_last_element.tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase("4","2 4 6 8 10","4")]
        [TestCase("4","2 4 6 8","2")]
        [TestCase("1","2 4 6 8 10","10")]
        public void should_return_mth_when_given_list(string M, string L,string res)
        {
            var result = m_th_to_last_element.core.Program.find_mth_element_from_tail(M, L);

            Assert.AreEqual(result, res);

        }

        [TestCase("8","2 4 6 8 10","NIL")]
        [TestCase("3","2 4","NIL")]
        public void should_return_nil_when_given_list_less_than_M(string M, string L,string res)
        {
            var result = m_th_to_last_element.core.Program.find_mth_element_from_tail(M, L);

            Assert.AreEqual(result, res);

        }

        [TestCase("8","2 4 6 8 10","NIL")]
        [TestCase("0","2 4","NIL")]
        public void should_return_nil_when_M_is_invalid(string M, string L,string res)
        {
            var result = m_th_to_last_element.core.Program.find_mth_element_from_tail(M, L);

            Assert.AreEqual(result, res);

        }

    }
}