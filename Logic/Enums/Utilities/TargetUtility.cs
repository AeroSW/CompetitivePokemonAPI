using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Enums.Utilities
{
    class TargetUtility
    {
        public static string ToString(Target target)
        {
            switch (target)
            {
                case Target.ONE:
                    return "one";
                case Target.SELF:
                    return "self";
                case Target.ALLY:
                    return "ally";
                case Target.OPPOSING:
                    return "opposing";
                case Target.ALL:
                    return "all";
                case Target.ADJACENT:
                    return "adjacent";
            }
            throw new NotImplementedException("Provided Target Category has not been implemented yet.");
        }
        public static Target ToEnum(string target)
        {
            var tempTarget = target.ToUpper().ToLower();
            switch (tempTarget)
            {
                case "one":
                    return Target.ONE;
                case "self":
                    return Target.SELF;
                case "ally":
                    return Target.ALLY;
                case "opposing":
                    return Target.OPPOSING;
                case "all":
                    return Target.ALL;
                case "adjacent":
                    return Target.ADJACENT;
            }
            throw new NotImplementedException("Provided Target Category has not been implemented yet.");
        }
    }
}
