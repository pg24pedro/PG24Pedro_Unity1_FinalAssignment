using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager:MonoBehaviour
{
    [SerializeField]
    GameObject _squarePrefab;

    List<IPlatform> _platforms;
    Transform _transform;
    List<Vector3> _downDirections, _upDirections;

    private void Awake()
    {
        _transform = transform;

        _downDirections = new List<Vector3>
        {
            new Vector3(3,-3,0),
            new Vector3(0,-3,-3)
        };

        _upDirections = new List<Vector3>
        { 
            new Vector3(-3,3,0),
            new Vector3(0,3,3)
        };

    }

    public int UnflippedPlatforms => _platforms.Count(p => !p.Flipped);
    public static readonly Vector3 NoChange = Vector3.up;
    public static readonly Vector3 NorthEast = Vector3.zero;
    public static readonly Vector3 NorthWest = new Vector3(0, 270, 0);
    public static readonly Vector3 SouthEast = new Vector3(0, 0, 90);
    public static readonly Vector3 SouthWest = new Vector3(0,180,0);

    /*public void SetUpBoard
    {
        //if(_platforms?.count)
        
    }*/

}