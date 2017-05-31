using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// This calss handle all violations of business rules
[Serializable ]
public class BusinessRuleException :Exception 
{
    public List<string> RuleDetails { get; set; }
    public BusinessRuleException(string message, List<string> reason) :base(message)
    {
       this:RuleDetails = reason;
    }
}