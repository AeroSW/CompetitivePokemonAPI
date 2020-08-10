using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Enums.Utilities
{
    class CategoryUtility
    {
        public static string ToString(Category cat) {
            switch (cat)
            {
                case Category.PHYSICAL:
                    return "physical";
                case Category.SPECIAL:
                    return "special";
                case Category.STATUS:
                    return "status";
            }
            throw new NotImplementedException("Provided category has not been implemented yet.");
        }
        public static Category ToEnum(string cat)
        {
            var tempCat = cat.ToUpper().ToLower();
            switch (tempCat)
            {
                case "physical":
                    return Category.PHYSICAL;
                case "special":
                    return Category.SPECIAL;
                case "status":
                    return Category.STATUS;
            }
            throw new NotImplementedException("Provided category has not been implemented yet.");
        }
    }
}
