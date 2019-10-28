using System;
using System.Collections.Generic;
using System.Text;

namespace BitFlagger
{
    public class USStateBitFlags : _BitFlager
    {
         static USStateBitFlags()

        {
            Initialize(new string[]{  "AK", "AL", "AR", "AZ", "CA", "CO", "CT", "DC",
                                            "DE", "FL", "GA", "HI", "IA", "ID", "IL", "IN", "KS", "KY", "LA",
                                            "MA", "MD", "ME", "MI", "MN", "MO", "MS", "MT", "NC", "ND", "NE",
                                            "NH", "NJ", "NM", "NV", "NY", "OH", "OK", "OR", "PA", "RI", "SC",
                                            "SD", "TN", "TX", "UT", "VA", "VT", "WA", "WI", "WV", "WY"
                                            });
        }
        
    }
}
