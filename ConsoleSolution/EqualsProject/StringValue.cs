using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualsProject
{
  class StringValue
  {
    public string Value { get; }

    public StringValue(string value)
    {
      this.Value = value;
    }

    public override bool Equals(object obj)
    {
      if (obj.GetType() != this.GetType())
      {
        return false;
      }

      StringValue other = (StringValue) obj;
      return (this.Value == other.Value);
    }
  }
}
