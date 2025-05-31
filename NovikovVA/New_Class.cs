using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovikovVA
{
    internal class New_Class
    {using NUnit.Framework;
using System.Collections.Generic;

namespace Beginer.Table
    {
        public class Table
        {
            public double X { get; set; }
            public double Y { get; set; }
        }
        [TestFixture]
        public class table_should
        {
            [Test]
            public void tableWithoutDublicat()
            {
                var result = Program.SortTable(
                    new List<Table>
                        {
                        new Table
                        {
                            X = 2.0,
                            Y = 122.0
                        },
                        new Table
                        {
                            X = 4.0,
                            Y = 114.0
                        },
                        new Table
                        {
                            X = 16.0,
                            Y = 14.0
                        },
                        new Table
                        {
                            X = 3.0,
                            Y = 93.5
                        },
                        new Table
                        {
                            X = 6.0,
                            Y = 120.0
                        },
                        new Table
                        {
                            X = 12.0,
                            Y = 8.7
                        },
                        new Table
                        {
                            X = 5.0,
                            Y = 211.0
                        },
                        });

                CollectionAssert.AreEqual(new[,] { { 2, 3, 4, 5, 6, 12, 16 }, { 122, 93.5, 114, 211, 120, 8.7, 14 } }, result);
            }

            [Test]
            public void tableWithOneDublicat()
            {
                var result = Program.SortTable(
                    new List<Table>
                        {
                        new Table
                        {
                            X = 2.0,
                            Y = 122.0
                        },
                        new Table
                        {
                            X = 4.0,
                            Y = 114.0
                        },
                        new Table
                        {
                            X = 16.0,
                            Y = 14.0
                        },
                        new Table
                        {
                            X = 3.0,
                            Y = 93.5
                        },
                        new Table
                        {
                            X = 4.0,
                            Y = 120.0
                        },
                        new Table
                        {
                            X = 12.0,
                            Y = 8.7
                        },
                        new Table
                        {
                            X = 5.0,
                            Y = 211.0
                        },
                        });

                CollectionAssert.AreEqual(new[,] { { 2, 3, 4, 5, 12, 16 }, { 122, 93.5, 117, 211, 8.7, 14 } }, result);
            }

            [Test]
            public void tableWithDoubleDublicat()
            {
                var result = Program.SortTable(
                    new List<Table>
                        {
                        new Table
                        {
                            X = 12.0,
                            Y = 122.0
                        },
                        new Table
                        {
                            X = 4.0,
                            Y = 114.0
                        },
                        new Table
                        {
                            X = 16.0,
                            Y = 14.0
                        },
                        new Table
                        {
                            X = 3.0,
                            Y = 93.5
                        },
                        new Table
                        {
                            X = 4.0,
                            Y = 120.0
                        },
                        new Table
                        {
                            X = 12.0,
                            Y = 8.7
                        },
                        new Table
                        {
                            X = 5.0,
                            Y = 211.0
                        },
                        });

                CollectionAssert.AreEqual(new[,] { { 3, 4, 5, 12, 16 }, { 93.5, 117, 211, 65.35, 14 } }, result);
            }

            [Test]
            public void tableWithTriplicatInEnd()
            {
                var result = Program.SortTable(
                    new List<Table>
                        {
                        new Table
                        {
                            X = 16.0,
                            Y = 122.0
                        },
                        new Table
                        {
                            X = 4.0,
                            Y = 114.0
                        },
                        new Table
                        {
                            X = 16.0,
                            Y = 14.0
                        },
                        new Table
                        {
                            X = 3.0,
                            Y = 93.5
                        },
                        new Table
                        {
                            X = 4.0,
                            Y = 120.0
                        },
                        new Table
                        {
                            X = 12.0,
                            Y = 8.7
                        },
                        new Table
                        {
                            X = 16.0,
                            Y = 212.0
                        },
                        });

                CollectionAssert.AreEqual(new[,] { { 3, 4, 12, 16 }, { 93.5, 117, 8.7, 116 } }, result);
            }

            [Test]
            public void tableWithTriplicatInBegin()
            {
                var result = Program.SortTable(
                    new List<Table>
                        {
                        new Table
                        {
                            X = 1.0,
                            Y = 122.0
                        },
                        new Table
                        {
                            X = 4.0,
                            Y = 114.0
                        },
                        new Table
                        {
                            X = 1.0,
                            Y = 14.0
                        },
                        new Table
                        {
                            X = 3.0,
                            Y = 93.5
                        },
                        new Table
                        {
                            X = 4.0,
                            Y = 120.0
                        },
                        new Table
                        {
                            X = 12.0,
                            Y = 8.7
                        },
                        new Table
                        {
                            X = 1.0,
                            Y = 212.0
                        },
                        });

                CollectionAssert.AreEqual(new[,] { { 1, 3, 4, 12 }, { 116, 93.5, 117, 8.7 } }, result);
            }

            [Test]
            public void tableWithAllDublicat()
            {
                var result = Program.SortTable(
                    new List<Table>
                        {
                        new Table
                        {
                            X = 0.0,
                            Y = 122.0
                        },
                        new Table
                        {
                            X = 0.0,
                            Y = 114.0
                        },
                        new Table
                        {
                            X = 0.0,
                            Y = 14.0
                        },
                        new Table
                        {
                            X = 0.0,
                            Y = 93.5
                        },
                        });

                CollectionAssert.AreEqual(new[,] { { 0 }, { 85.875 } }, result);
            }
        } //end class
    } // end namespace

}
}
