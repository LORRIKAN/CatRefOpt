namespace Researcher.View.InterfaceElements.Validation
{
    public interface IValidatableContainer : IValidatableControl
    {
        ValidatableContainerLogic ValidatableContainerLogic { get; }
    }
}
