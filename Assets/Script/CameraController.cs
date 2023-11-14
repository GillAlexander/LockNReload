using UnityEngine;
using UnityEngine.EventSystems;

public class CameraController : MonoBehaviour
{
    public GameObject hitPrefab;
    public CommandCenter commandCenter;
    private GameObject spawnedHitPrefab;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray v = Camera.main.ScreenPointToRay(Input.mousePosition, Camera.MonoOrStereoscopicEye.Mono);
            Debug.DrawRay(v.origin, v.direction * 20, Color.yellow);
            Debug.LogError(v);

            var lastRaycastHit = new RaycastHit();
            var ray = Physics.Raycast(v, out lastRaycastHit);
            Debug.DrawLine(v.origin, lastRaycastHit.point, Color.yellow, 3f);
            GameObject.Destroy(spawnedHitPrefab);
            spawnedHitPrefab = Instantiate(hitPrefab, lastRaycastHit.point, Quaternion.identity);

            commandCenter.MoveCommand(lastRaycastHit.point);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {

        }
        if (Input.GetKeyDown(KeyCode.A))
        {

        }
        if (Input.GetKeyDown(KeyCode.S))
        {

        }
        if (Input.GetKeyDown(KeyCode.D))
        {

        }
    }
}
