using System;
using System.Collections.Generic;
namespace DotnetIntern2021.Basic
{
    public class Exercise13
    {
        public List<String> RestoreIpAddresses(String s)

        {
            var result = new List<String>();
            for (int a = 0; a <= 255; a++)
            {
                var ip1 = a.ToString();
                if (s.StartsWith(ip1))
                    for (int b = 0; b <= 255; b++)
                    {
                        var ip2 = ip1 + b;

                        if (s.StartsWith(ip2))
                            for (int c = 0; c <= 255; c++)
                            {
                                var ip3 = ip2 + c.ToString();
                                if (s.StartsWith(ip3))
                                    for (int d = 0; d <= 255; d++)
                                    {
                                        if (s.CompareTo(ip3 + d.ToString()) == 0)
                                        {
                                            result.Add($"{a}.{b}.{c}.{d}");

                                        }
                                    }
                            }
                    }
            }

            return result;
        }


    }
}
