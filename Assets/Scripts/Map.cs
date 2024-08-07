using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {

    public int map;
    [SerializeField] List<Level> levels;
    void Start() {
        RandomiseMap();
    }
    public void RandomiseMap() {
        foreach (Level e in levels) {
            if (levels.IndexOf(e) == 0) {
                e.RandomiseLevel(true, 1);
            } else {
                e.RandomiseLevel(false, 0);
            }
        }
    }
}
