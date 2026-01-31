using System;

namespace Time_Based_Key_Value_Store;

public class TimeMap {
	private readonly Dictionary<string, List<(int time, string val)>> Store = [];
	
	public void Set(string key, string value, int timestamp) {
		var item = (timestamp, value);
		if (Store.TryGetValue(key, out var snapshots)) {
			snapshots.Add(item);
		}
		else {
			Store.Add(key, [item]);
		}
	}
	
	public string Get(string key, int timestamp) {
		if (!Store.TryGetValue(key, out var snapshots))
			return string.Empty;

		int right = snapshots.Count - 1;
		int left = 0;

		while (left <= right) {
			int mid = (left + right) / 2;

			if (timestamp < snapshots[mid].time)
				right = mid - 1;
			else if (timestamp > snapshots[mid].time)
				left = mid + 1;
			else
				return snapshots[mid].val;
		}

		return right == -1 ? string.Empty : snapshots[right].val;
	}
}
