using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractFacade : MonoBehaviour
{
    public abstract IEnumerator Save(double score);
}

public class CloudStorageFacade : AbstractFacade
{
    public override IEnumerator Save(double score)
    {
        yield break;
    }
}

public class LocalStorageFacade : AbstractFacade
{
    public override IEnumerator Save(double score)
    {
        yield break;
    }
}