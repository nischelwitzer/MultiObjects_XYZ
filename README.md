# MultiObjects_XYZ
automatic 3D MultiObjects with physics in X/Y/Z in C# with Unity.
Lecture Example Master File[^1].

1. create a prefab (showALot)
   - with physics (rigidBody)
1. clone the prefab in the 3 room X/Y/Z (see code example)
   - Instantiate (clone)
   - get renderer
   - change color 

## ShowALot

```
GameObject clone;
Vector3 goVector = new Vector3(runx, (runy+5)/5F, runz);
clone = (GameObject) Instantiate(showALot, goVector, Quaternion.identity);

rend = clone.GetComponent<Renderer>();
Color aColor = new Vector4((runx+5)/10F, (runy-1)/20F, (runz+5)/10F, 1);
rend.material.SetColor("_Color", aColor);
```

[^1] \01_unity\0000_master_files\C#_v10\Assets\Scripts\Medien

