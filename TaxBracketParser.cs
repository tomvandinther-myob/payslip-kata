using Microsoft.VisualBasic.FileIO;
using System.Collections.Generic;
using System.Diagnostics;

class TaxBracketParser {
    public TaxBracketParser() {}

    public TaxBracket[] ParseCSV(string filepath)
    {
        using (TextFieldParser parser = new TextFieldParser(filepath)) {
            parser.Delimiters = new string[] { "," };
            List<TaxBracket> brackets = new List<TaxBracket>();
            while (true) {
                string[] row = parser.ReadFields();
                if (row == null) {
                    break;
                }
                
                Debug.Assert(row.Length == 2, "Expecting a tax bracket to consist of 2 comma separated values.");
                try
                {
                    TaxBracket bracket;
                    bracket.threshold = int.Parse(row[0]);
                    bracket.rate = double.Parse(row[1]);
                    brackets.Add(bracket);
                }
                catch (System.FormatException)
                {}                
            }
            return brackets.ToArray();
        }
    }
}