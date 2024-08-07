using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour {



    [SerializeField] GameManager manager;
    [SerializeField] Map map;
    //0 = normal
    //1 = fight
    //2 = boss
    [SerializeField] int levelStage;
    [SerializeField] int rows;
    [SerializeField] List<GameObject> subLevels;

    void Start() {
        if(levelStage == 2) {
            if (map.map == 1) {
                Instantiate(manager.prospectorBoss, subLevels[0].transform);
            } else if (map.map == 2) {
                Instantiate(manager.anglerBoss, subLevels[0].transform);
            } else if (map.map == 3) {
                Instantiate(manager.trapperTraderBoss, subLevels[0].transform);
            }
        }
    }
    public void RandomiseLevel(bool forceRows, int rowNum) {
        if (forceRows) {
            rows = rowNum;
        } else {
            if (levelStage == 0)
            rows = Random.Range(1, 4);
            else
            rows = Random.Range(1, 3);
        }
        if (levelStage == 0) {

            if (rows == 1) {
                RandomNormal(subLevels[3]);
            } else if (rows == 2) {
                RandomNormal(subLevels[2]);
                RandomNormal(subLevels[4]);
            } else if (rows == 3) {
                RandomNormal(subLevels[1]);
                RandomNormal(subLevels[3]);
                RandomNormal(subLevels[5]);
            }

        } else if (levelStage == 1) {

            if (rows == 1) {
                RandomFight(subLevels[3]);
            } else if (rows == 2) {
                RandomFight(subLevels[2]);
                RandomFight(subLevels[4]);
            }
        }
    }
    void RandomFight(GameObject marker) {
        int randNum = Random.Range(1,101);
        Debug.Log(randNum + " " + gameObject.name);
        if ((randNum >= manager.cardBattlePercent.x) && (randNum <= manager.cardBattlePercent.y))
            Instantiate(manager.cardBattle, marker.transform);

        else if ((randNum >= manager.totemBattlePercent.x) && (randNum <= manager.totemBattlePercent.y))
            Instantiate(manager.totemBattle, marker.transform);
    }
    void RandomNormal(GameObject marker) {
        int randNum = Random.Range(1,101);
        //Debug.Log(randNum);
        if ((randNum >= 1) && (randNum <= manager.woodcarverPercent.y))
            Instantiate(manager.woodcarver, marker.transform);

        else if ((randNum >= manager.trapperPercent.x) && (randNum <= manager.trapperPercent.y))
            Instantiate(manager.trapper, marker.transform);
            
        else if ((randNum >= manager.traderPercent.x) && (randNum <= manager.traderPercent.y))
            Instantiate(manager.trader, marker.transform);
            
        else if ((randNum >= manager.mycologistPercent.x) && (randNum <= manager.mycologistPercent.y))
            Instantiate(manager.mycologist, marker.transform);
            
        else if ((randNum >= manager.cardChoicePercent.x) && (randNum <= manager.cardChoicePercent.y))
            Instantiate(manager.cardChoice, marker.transform);
            
        else if ((randNum >= manager.costChoicePercent.x) && (randNum <= manager.costChoicePercent.y))
            Instantiate(manager.costChoice, marker.transform);
            
        else if ((randNum >= manager.tribeChoicePercent.x) && (randNum <= manager.tribeChoicePercent.y))
            Instantiate(manager.tribeChoice, marker.transform);
            
        else if ((randNum >= manager.caveTrialPercent.x) && (randNum <= manager.caveTrialPercent.y))
            Instantiate(manager.caveTrial, marker.transform);
            
        else if ((randNum >= manager.sigilTransferPercent.x) && (randNum <= manager.sigilTransferPercent.y))
            Instantiate(manager.sigilTransfer, marker.transform);
            
        else if ((randNum >= manager.packPercent.x) && (randNum <= manager.packPercent.y))
            Instantiate(manager.pack, marker.transform);
            
        else if ((randNum >= manager.campfirePercent.x) && (randNum <= manager.campfirePercent.y))
            Instantiate(manager.campfire, marker.transform);
            
        else if ((randNum >= manager.boneLordPercent.x) && (randNum <= manager.boneLordPercent.y))
            Instantiate(manager.boneLord, marker.transform);
    }
}
