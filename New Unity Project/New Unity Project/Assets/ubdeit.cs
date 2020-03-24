using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "ManagerUpdate", menuName = "Managers/ManagerUpdate")]
public class ManagerUpdate : ManagerBase, IAwake
{
    private List<ITick> ticks = new List<ITick>();
    private List<ITickFixed> ticksFixes = new List<ITickFixed>();
    private List<ITickilate> tickslates = new List<ITickilate>();



    public static void AddTo(object updateble)
    {
        var mngUpdate = Toolbox.Get<ManagerUpdate>();
        if (updateble is ITick)
            mngUpdate.ticks.Add(updateble as ITick);
        if (updateble is ITickFixed)
            mngUpdate.ticksFixes.Add(updateble as ITickFixed);
        if (updateble is ITickLate)
            mngUpdate.ticksLate.Add(updateble as ITickLate);
    }

    public static void BemoveFrom(object updateble)
    {
        var mngUpdate = Toolbox.Get<ManagerUpdate>();
        if (updateble is ITick)
            mngUpdate.ticks.Remove(updateble as ITick);
        if (updateble is ITickFixed)
            mngUpdate.ticksFixes.Remove(updateble as ITickFixed);
        if (updateble is ITickLate)
            mngUpdate.ticksLate.Remove(updateble as ITickLate);

    }
    public void Tick()
    {
        for (var i=0; i < ticks.Count; i++)
        {
            ticks[i].Tick();
        }
    }
    public void TickFixed()
    {   for (var i = 0; i < ticksFixes.Count; i++)
        {
            ticksFixes[i].TickFixed();
        }
    }
    public void TicKLate()
    {
        for (var i=0;i< ticksLate.Count; i++)
        {
            ticksLates[i].TickLate();
        }
    }
    public void OnAwake()
    {
        GameObject.Find("[SETUP]").Add.Component<ManagerUpdateComponent>().Setup(this);
    }
}