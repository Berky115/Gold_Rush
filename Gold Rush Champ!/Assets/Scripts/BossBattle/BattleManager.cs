using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public enum PlayerAction { None, PanAttack, Run };

    PlayerAction playerNextAction;
    string playerActionText = "";

    public List<Item> FinalBossList;
    int currentCollectionIndex = 0;

    public int PlayerHealth = 100;
    public int BossHealth = 100;

    public GameObject FightStart;
    public GameObject BossAttack;
    public GameObject PlayerAttack;
    public GameObject DeathScreen;
    public GameObject PlayerChoiceMenu;

    public Inventory TheInventory;

    public Health PlayerHealthBar;
    public Health BossHealthBar;

    public AttackInfoUI AttackUI;
    public PlayerActionUI messagePlayerUI;


    // Start is called before the first frame update
    void Start()
    {

        //Set up UI Visibility
        FightStart.SetActive(true);
        BossAttack.SetActive(false);
        PlayerAttack.SetActive(false);
        DeathScreen.SetActive(false);
        PlayerChoiceMenu.SetActive(false);
        
        //Set Health Bars
        PlayerHealthBar.SetMaxHealth(PlayerHealth);
        BossHealthBar.SetMaxHealth(BossHealth);
    }

    public void StartBattle()
    {
        TheInventory.ReloadPile();


        FinalBossList = TheInventory.GetKeptItems();
        if(FinalBossList.Count == 0)
        {
            Debug.Log("Error: Battle Manager has no list of kept items");
        }


        //Hide Start menu
        FightStart.SetActive(false);

        StartCoroutine(BattleFlow());
    }

    public IEnumerator BattleFlow()
    {
        while (PlayerHealth >= 0)
        {
            Debug.Log("A Round Begins");

            yield return new WaitForSeconds(2);

            //BOSS ATTACK
            yield return StartCoroutine(BossAttacks());

            //PLAYER ATTACK -waits for input
            yield return StartCoroutine(DoPlayerAction());

        }

        yield return new WaitForSeconds(2);

        //DEATH ACTIONS
        DeathScreen.SetActive(true);
    }

    public IEnumerator DoPlayerAction()
    {
        //SHOW OPTIONS
        PlayerChoiceMenu.SetActive(true);

        //Wait for input
        while (playerNextAction == PlayerAction.None)
        {
            yield return null;
        }

        PlayerChoiceMenu.SetActive(false);

        PlayerAttack.SetActive(true);
        messagePlayerUI.DisplayText("Title", playerActionText);
        Debug.Log(playerActionText);

        yield return new WaitForSeconds(2);


        PlayerAttack.SetActive(false);
        playerNextAction = PlayerAction.None;
    }

    public IEnumerator BossAttacks()
    {
        Item attackerItem = FinalBossList[currentCollectionIndex];

        //ATTACK TEXT

        BossAttack.SetActive(true);
        AttackUI.SetUI(attackerItem);

        Debug.Log(attackerItem.AttackText);
        yield return new WaitForSeconds(2);
        BossAttack.SetActive(false);

        //DAMAGE
        int dmg = attackerItem.AttackDamage;
        PlayerHealth -= dmg;
        PlayerHealthBar.SetHealth(PlayerHealth);
        Debug.Log("The attack does "+dmg+" dmg");
        yield return new WaitForSeconds(2);


        //NEXT TURN SET UP
        currentCollectionIndex++;
        if(currentCollectionIndex >= FinalBossList.Count)
        {
            currentCollectionIndex = 0;
        }
    }

    public void PickPlayerAction(PlayerAction action)
    {
        playerNextAction = action;
    }

    #region Player Actions
    public void PlayerRun()
    {
        playerNextAction = PlayerAction.Run;
        playerActionText = "There is no escape.";

        //IEnumerator coroutine = DoPlayerAction("You attack with your pan.  It does nothing against the monster.");
        //StartCoroutine(coroutine);
    }

    public void PlayerPanAttack()
    {
        playerNextAction = PlayerAction.PanAttack;
        playerActionText = "You attack with your pan.It does nothing against the monster.";

        //IEnumerator coroutine = DoPlayerAction("There is no escape.");
        //StartCoroutine(coroutine);
    }
    #endregion


}
