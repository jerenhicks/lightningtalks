using System;
using System.Collections.Generic;
public class TalkDay {
    public string id { get; set; }
    public Slot slot1 { get; set; }
    public Slot slot2 { get; set; }
    public Slot slot3 { get; set; }
    public Slot slot4 { get; set; }
    public double startDateTime { get; set; }
    public string theme { get; set; }

    public DateTime getStartDateTimeObj() {
        DateTimeOffset dateTimeOffset2 = DateTimeOffset.FromUnixTimeMilliseconds((long) startDateTime);
        return dateTimeOffset2.DateTime;
    }

    public List<Slot> nonNullSlots() {
        List<Slot> slots = new List<Slot>();
        if (slot1 != null) {
            slots.Add(slot1);
        }
        if (slot2 != null) {
            slots.Add(slot2);
        }
        if(slot3 != null) {
            slots.Add(slot3);
        }
        if(slot4 != null) {
            slots.Add(slot4);
        }
        return slots;
    }

}