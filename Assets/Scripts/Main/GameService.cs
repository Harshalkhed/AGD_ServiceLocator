using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ServiceLocator.Player;
using ServiceLocator.Utilities;

public class GameService : GenericMonoSingleton<GameService>

{
  
    public  PlayerService playerService { get; private set; }

    [SerializeField] public PlayerScriptableObject playerScriptableObject;


    private void Start()
    {
         playerService = new PlayerService(playerScriptableObject);
    }

    private void Update()
    {
        playerService.Update();
    }
}
