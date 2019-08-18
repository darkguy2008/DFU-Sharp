﻿using System;
using CommandLine;
using CommandLine.Text;

namespace WildernessLabs.DfuSharp.Cli
{
    public class Options
    {
        [Option('l', "List", Required = false, HelpText = "Lists attached DFU devices")]
        public bool List { get; set; }
    }
}
