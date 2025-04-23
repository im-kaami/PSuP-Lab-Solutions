#!/bin/bash

NUM_LABS=13

for i in $(seq -w 1 $NUM_LABS); do
    mkdir -p "Lab$i"
    cat <<EOF > "Lab$i/Lab$i.cs"
using System;

namespace PSuP_Lab$i
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            Console.WriteLine("Task 1");
            #endregion

            #region Task 2
            Console.WriteLine("Task 2");
            #endregion
        }
    }
}
EOF

    echo "# Lab $i" > "Lab$i/README.md"
    echo "Solutions for Lab $i using C#." >> "Lab$i/README.md"
done

echo "✅ 13 Lab folders created with .cs and README.md files."


