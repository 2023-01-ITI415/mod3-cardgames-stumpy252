using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class JsonPip{
    public string type = "pip";// pip, letter, or suit
    public Vector3 loc;//Location of sprite on card
    public bool flip = false;//true to flip sprite vertically
    public float scale = 1;//scale of sprite
}
//class stores information for each rank of card
[System.Serializable]
public class JsonCard{
    public int rank; //the rank(1-13) of the card
    public string face; //sprite to use for each face card
    public List<JsonPip> pips = new List<JsonPip>(); // the pips on this card
}
//class contains information of the entire deck
[System.Serializable]
public class JsonDeck{
    public List<JsonPip> decorators = new List<JsonPip>(); 
    public List<JsonCard> cards = new List<JsonCard>();
}
public class JsonParseDeck : MonoBehaviour
{
   [Header("Inscribed")]
   public TextAsset jsonDeckFile; //Reference to JSON_DECK text file
   [Header("Dynamic")]
   public JsonDeck deck;
   void Awake(){
        deck = JsonUtility.FromJson<JsonDeck>(jsonDeckFile.text);
   }
  
}