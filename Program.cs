﻿using System.ComponentModel;

namespace vscode_bug;

public class Program
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
    static void Main(string[] args)
    {
        Add(1, 2);
    }
}
