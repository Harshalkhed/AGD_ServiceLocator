using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ServiceLocator.Player;
using ServiceLocator.Utilities;
using ServiceLocator.Sound;
using ServiceLocator.UI;
using ServiceLocator.Wave;
using ServiceLocator.Map;
using ServiceLocator.Events;

public class GameService : GenericMonoSingleton<GameService>

{
  
    public  PlayerService playerService { get; private set; }
    public SoundService soundService { get; private set; }
    public WaveService waveService { get; private set; }
    public MapService mapService { get; private set; }
    [SerializeField]
    private UIService uIService;
    public UIService UIService => uIService;

    [SerializeField] private MapScriptableObject mapScriptableObject;
    [SerializeField] private WaveScriptableObject waveScriptableObject;
    [SerializeField] public PlayerScriptableObject playerScriptableObject;
    [SerializeField] private SoundScriptableObject soundScriptableObject;
    [SerializeField] private AudioSource audioEffects;
    [SerializeField] private AudioSource backgroundMusic;

    private void Start()
    {
       
        mapService = new MapService(mapScriptableObject);
        waveService = new WaveService(waveScriptableObject);
         playerService = new PlayerService(playerScriptableObject);
        soundService = new SoundService(soundScriptableObject, audioEffects, backgroundMusic);
    }

    private void Update()
    {
        playerService.Update();
        
    }
    
}
