namespace VehicleManagementSystem.Errors
{
    public abstract class SystemError
    {
        public abstract string ErrorMessage();
    }

    public class EngineFailureError : SystemError
    {
        public override string ErrorMessage() => "Motorfel: Kontrollera motorstatus!";
    }

    public class BrakeFailureError : SystemError
    {
        public override string ErrorMessage() => "Bromsfel: Fordonet är osäkert att köra!";
    }

    public class TransmissionError : SystemError
    {
        public override string ErrorMessage() => "Växellådsproblem: Reparation krävs!";
    }
}
