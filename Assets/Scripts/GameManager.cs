using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerHealth Player;
    
    private static GameManager _instance;
    
    //---------------------------------------------------------------------
    // Properties
    //---------------------------------------------------------------------

    public static GameManager Instance
    {
        get { return _instance; }
    }

    //---------------------------------------------------------------------
    // Messages
    //---------------------------------------------------------------------
    
    private void Awake()
    {
        //This is a common approach to handling a class with a reference to itself.
        //If instance variable doesn't exist, assign this object to it
        if (_instance == null)
        {
            _instance = this;
        }
        //Otherwise, if the instance variable does exist, but it isn't this object, destroy this object.
        //This is useful so that we cannot have more than one GameManager object in a scene at a time.
        else if (_instance != this)
        {
            Destroy(this);
        }
    }
    
}
