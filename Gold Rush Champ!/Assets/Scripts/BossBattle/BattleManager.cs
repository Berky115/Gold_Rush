using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public enum PlayerAction { None, PanAttack, Run };

    PlayerAction playerLastAction;
    bool isPlayerTurn = false;
    bool playerHasActed = false;
    string playerActionText = "";


    public List<Item> FinalBossList;
    int currentCollectionIndex = 0;
    bool collectionHasActed = false;

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


    // Start is called before the first frame update
    void Start()
    {
        isPlayerTurn = false;
        TheInventory.ReloadPile();
        FightStart.SetActive(true);
        BossAttack.SetActive(false);
        PlayerAttack.SetActive(false);
        DeathScreen.SetActive(false);
        PlayerChoiceMenu.SetActive(false);


        PlayerHealthBar.SetMaxHealth(PlayerHealth);
        BossHealthBar.SetMaxHealth(BossHealth);
    }

    //// Update is called once per frame
    //void Update()
    //{

    //    //if(PlayerHealth <= 0)
    //    //{
    //    //    //Launch End State
    //    //    return;
    //    //}

    //    //if(isPlayerTurn == false)
    //    //{
    //    //    ////The Collection's Turn
    //    //    //if (collectionHasActed)
    //    //    //{
    //    //    //    BossAttacks();
    //    //    //}


    //    //}
    //    //else
    //    //{
    //    //    //The Player's turn
    //    //    if (playerLastAction != PlayerAction.None)
    //    //    {
    //    //        //if (playerHasActed)
    //    //        //{
    //    //        //    //DoPlayerAction();
    //    //        //}
    //    //    }
    //    //}
    //}

    public void StartBattle()
    {
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
        while (playerLastAction == PlayerAction.None)
        {
            yield return null;
        }

        PlayerChoiceMenu.SetActive(false);

        Debug.Log(playerActionText);

        yield return new WaitForSeconds(2);


        isPlayerTurn = false;
        playerLastAction = PlayerAction.None;
        playerHasActed = false;
    }

    public IEnumerator BossAttacks()
    {
        Item attackerItem = FinalBossList[currentCollectionIndex];

        //show dialogue
        //bool hasInput = false;
        //while (!hasInput)
        //{
        //    if (Input.GetKeyUp(KeyCode.Space))
        //    {

        //    }
        //    yield return null;
        //}

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

        isPlayerTurn = true;
        currentCollectionIndex++;
        if(currentCollectionIndex >= FinalBossList.Count)
        {
            currentCollectionIndex = 0;
        }
        collectionHasActed = false;
    }

    public void PickPlayerAction(PlayerAction action)
    {
        playerLastAction = action;
    }

    #region Player Actions
    public void PlayerRun()
    {
        playerLastAction = PlayerAction.Run;
        playerActionText = "There is no escape.";

        //IEnumerator coroutine = DoPlayerAction("You attack with your pan.  It does nothing against the monster.");
        //StartCoroutine(coroutine);
    }

    public void PlayerPanAttack()
    {
        playerLastAction = PlayerAction.PanAttack;
        playerActionText = "You attack with your pan.It does nothing against the monster.";

        //IEnumerator coroutine = DoPlayerAction("There is no escape.");
        //StartCoroutine(coroutine);
    }
    #endregion


}
