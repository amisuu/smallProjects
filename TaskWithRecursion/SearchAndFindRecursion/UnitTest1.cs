using NUnit.Framework;
using System;
public class UnitTest
{
    [Test]
    public void Ex1()
    {
        char[][] house =
        {
            "  o                o        #######".ToCharArray(),
            "###############             #     #".ToCharArray(),
            "#             #        o    #     #".ToCharArray(),
            "#  X          ###############     #".ToCharArray(),
            "#                                 #".ToCharArray(),
            "###################################".ToCharArray()
        };
        Assert.AreEqual(true, Dinglemouse.AllAlone(house));
    }

    [Test]
    public void Ex2()
    {
        char[][] house =
        {
            "#################             ".ToCharArray(),
            "#     o         #   o         ".ToCharArray(),
            "#          ######        o    ".ToCharArray(),
            "####       #                  ".ToCharArray(),
            "   #       ###################".ToCharArray(),
            "   #                         #".ToCharArray(),
            "   #                  X      #".ToCharArray(),
            "   ###########################".ToCharArray()
        };
        Assert.AreEqual(false, Dinglemouse.AllAlone(house));
    }
}