using System;
public class Slot {
    public string description{ get; set; }
    public string speakers { get; set; }
    public string topic { get; set; }
    public string videoUrl { get; set; }

    public string getOutputString(DateTime date, Boolean verbose = true) {
        String outputString = "";
        String DELIMETER = "/,";
        String nonVerboseFormat = "{0}" + DELIMETER + "{1}" + DELIMETER + "{2}";
        String verboseFormat = nonVerboseFormat + DELIMETER + "{3}";

        if(verbose) {
            outputString = String.Format(verboseFormat, date.ToShortDateString(), this.speakers, this.topic, this.description);
        } else {
            outputString = String.Format(nonVerboseFormat, date.ToShortDateString(), this.speakers, this.topic);
        }
        return outputString;
    }
}