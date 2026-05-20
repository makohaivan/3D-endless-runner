using UnityEngine;
using System.Collections;

public class SegmentGenerator : MonoBehaviour 
{
    // segments of the map, they will be activated one by one as the player progresses through the game
    public GameObject[] segment;
    
    [SerializeField] int zPos = 50; // the distance between each segment of the map, it will be used to position the segments correctly
    [SerializeField] bool creatingSegments = false; // a flag to control whether the segments should be created or not, it can be set to false to stop the generation of segments
    [SerializeField] int segmentNum; // the number of segments that have been created, it will be used to control the generation of segments and to position them correctly

    void Update()
        {
        if (creatingSegments == false) // check if the flag is false, if it is, start the generation of segments
        {
            creatingSegments = true; // set the flag to true to indicate that segments are being created
            StartCoroutine(SegmentGen());
        }
    }

    IEnumerator SegmentGen()
    {
        segmentNum = Random.Range(0, 3); // randomly select a segment from the array of segments to be the first segment of the map
        Instantiate(segment[segmentNum], new Vector3(0, 0, zPos), Quaternion.identity); // instantiate the first segment of the map at the correct position
        zPos += 50; // update the z position for the next segment
        yield return new WaitForSeconds(3);
        creatingSegments = false; // set the flag to false to stop the generation of segments after the first segment has been created
    }
    
}
