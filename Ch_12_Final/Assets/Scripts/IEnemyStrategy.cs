using System.Collections;
using System.Collections.Generic;

public interface IEnemyStrategy
{
    void Think();
    void React(EnemyContext context);
}