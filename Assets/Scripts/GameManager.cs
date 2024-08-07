using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.InputSystem;
public class GameManager : MonoBehaviour {

    [SerializeField] GameObject mainObject;
    [SerializeField] Button upButton;
    [SerializeField] Button downButton;
    [Space]
    public GameObject cardBattle;
    public Vector2Int cardBattlePercent;
    [Space]
    public GameObject totemBattle;
    public Vector2Int totemBattlePercent;
    [Space]
    public GameObject woodcarver;
    public Vector2Int woodcarverPercent;
    [Space]
    public GameObject trapper;
    public Vector2Int trapperPercent;
    [Space]
    public GameObject trader;
    public Vector2Int traderPercent;
    [Space]
    public GameObject mycologist;
    public Vector2Int mycologistPercent;
    [Space]
    public GameObject cardChoice;
    public Vector2Int cardChoicePercent;
    [Space]
    public GameObject costChoice;
    public Vector2Int costChoicePercent;
    [Space]
    public GameObject tribeChoice;
    public Vector2Int tribeChoicePercent;
    [Space]
    public GameObject caveTrial;
    public Vector2Int caveTrialPercent;
    [Space]
    public GameObject sigilTransfer;
    public Vector2Int sigilTransferPercent;
    [Space]
    public GameObject pack;
    public Vector2Int packPercent;
    [Space]
    public GameObject campfire;
    public Vector2Int campfirePercent;
    [Space]
    public GameObject boneLord;
    public Vector2Int boneLordPercent;
    [Space]
    public GameObject prospectorBoss;
    [Space]
    public GameObject anglerBoss;
    [Space]
    public GameObject trapperTraderBoss;
    [Space]
    public GameObject leshyBoss;

    public void GenerateNew() {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public void GoUp() {
        StartCoroutine(ButtonDisable());
        if (mainObject.transform.position.y == -90)
            return;
        else
            mainObject.transform.DOLocalMove(new Vector3(0, mainObject.transform.position.y - 5, 0), 0.25f);
    }
    public void GoDown() {
        StartCoroutine(ButtonDisable());
        if (mainObject.transform.position.y == 0)
            return;
        else
            mainObject.transform.DOLocalMove(new Vector3(0, mainObject.transform.position.y + 5, 0), 0.25f);
    }
    IEnumerator ButtonDisable() {
        upButton.interactable = false;
        downButton.interactable = false;
        GetComponent<PlayerInput>().enabled = false;
        yield return new WaitForSeconds(0.3f);
        upButton.interactable = true;
        downButton.interactable = true;
        GetComponent<PlayerInput>().enabled = true;
    }
    public void OnUp() {
        GoUp();
    }
    public void OnDown() {
        GoDown();
    }
}