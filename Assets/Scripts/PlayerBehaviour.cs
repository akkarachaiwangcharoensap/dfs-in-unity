using System.Collections.Generic;
using AkiWiki;
using UnityEngine;

using Vector2 = UnityEngine.Vector2;
public class PlayerBehaviour : MonoBehaviour
{
    private List<Vector2> paths;
    private float speed = 0.5f;
    private new Transform transform;

    private int nextPointIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.transform = this.GetComponent<Transform>();

        Vector2 start = new Vector2(-6, -4);
        Vector2 end = new Vector2(6, 4);

        this.paths = GraphBehaviour.DFS(start, end);
    }

    // Update is called once per frame
    void Update()
    {
        if (nextPointIndex < this.paths.Count)
        {
            Vector2 nextPoint = paths[nextPointIndex];

            // Calculate the direction vector from the current point to the target point
            Vector3 direction = ((Vector3)nextPoint - this.transform.position).normalized;
            direction.z = 0;

            // Move the object along the direction vector at the specified speed
            this.transform.position += direction * speed * Time.fixedDeltaTime;

            // Check if we've reached the target point, and move on to the next one if so
            if (Vector2.Distance(nextPoint, this.transform.position) < 0.01f)
            {
                nextPointIndex++;
            }
        }
    }
}
