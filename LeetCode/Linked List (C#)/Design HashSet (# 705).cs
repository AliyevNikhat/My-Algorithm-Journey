public class MyHashSet {

    private const int SIZE = 1000; 
    private LinkedList<int>[] buckets;

    public MyHashSet() {
        buckets = new LinkedList<int>[SIZE];
    }

    private int GetBucketIndex(int key) {
        return key % SIZE; 
    }

    public void Add(int key) {
        int index = GetBucketIndex(key);
        if (buckets[index] == null) {
            buckets[index] = new LinkedList<int>();
        }
        if (!buckets[index].Contains(key)) {
            buckets[index].AddLast(key);
        }
    }

    public void Remove(int key) {
        int index = GetBucketIndex(key);
        if (buckets[index] != null) {
            buckets[index].Remove(key);
        }
    }

    public bool Contains(int key) {
        int index = GetBucketIndex(key);
        return buckets[index] != null && buckets[index].Contains(key);
    }
}