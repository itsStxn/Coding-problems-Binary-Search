using Time_Based_Key_Value_Store;

var timeMap = new TimeMap();
timeMap.Set("foo", "bar", 1);						// store the key "foo" and value "bar" along with timestamp = 1.
Console.WriteLine(timeMap.Get("foo", 1));		// return "bar"
Console.WriteLine(timeMap.Get("foo", 3));		// return "bar", since there is no value corresponding to foo at timestamp 3 and timestamp 2, then the only value is at timestamp 1 is "bar".
timeMap.Set("foo", "bar2", 4);					// store the key "foo" and value "bar2" along with timestamp = 4.
Console.WriteLine(timeMap.Get("foo", 4));		// return "bar2"
Console.WriteLine(timeMap.Get("foo", 5));		// return "bar2"
