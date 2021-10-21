﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Diagnostics;
using TrClient;

namespace TrClient
{
    public class clsTrAbbrevTag : clsTrTextualTag
    {

        public string Expansion { get; set; }


        public clsTrAbbrevTag(int sOffset, int sLength, string sExpansion) : base("abbrev", sOffset, sLength)
        {
            // constructor for adding NEW tag programmatically

            Expansion = sExpansion;
        }


        public clsTrAbbrevTag(string sProperties) : base("abbrev", sProperties)
        {
            // constructor for reading XML files

            string PropName;
            string PropValue;

            Expansion = "";

            for (int i = 0; i < Properties.Count; i++)
            {
                PropName = Properties[i].Name;
                PropValue = Properties[i].Value;

                switch (PropName)
                {
                    case "expansion":
                        Expansion = Regex.Unescape(PropValue);
                        break;
                    default:
                        break;
                }
            }

        }

        public override bool IsEmpty
        {
            get
            {
                _isEmpty = Expansion == "";
                return _isEmpty;
            }
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Type);
            sb.Append(" {");

            sb.Append("offset:");
            sb.Append(Offset.ToString());
            sb.Append("; ");

            sb.Append("length:");
            sb.Append(Length.ToString());
            sb.Append("; ");

            if (Expansion != "")
            {
                sb.Append("expansion:");
                sb.Append(clsTrLibrary.EscapeString(Expansion));
                sb.Append("; ");
            }

            sb.Append("}");

            return sb.ToString();
        }




    }
}
