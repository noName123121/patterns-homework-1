public class IdlingState : GroundedState
{
    public IdlingState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
    { }

    public override void Enter()
    {
        base.Enter();

        Data.Speed = 0;

        View.StartIdling();
    }

    public override void Exit()
    {
        base.Exit();

        View.StopIdling();
    }

    public override void Update()
    {
        base.Update();
        
        if (IsHorizontalInputZero())
            return;

        if (WantsToSprint())
        {
            StateSwitcher.SwitchState<SprintingState>();
            return;
        }
        if (WantsToWalk())
        {
            StateSwitcher.SwitchState<WalkingState>();
            return;
        }

        StateSwitcher.SwitchState<RunningState>();
    }
}
