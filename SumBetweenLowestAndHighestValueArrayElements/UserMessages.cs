using SumBetweenLowestAndHighestValueArrayElements.Interfaces;

namespace SumBetweenLowestAndHighestValueArrayElements;

public class UserMessages
{
    private readonly IWriter _writer;
    private readonly RequestUserInput _requestUserInput;

    public UserMessages(IWriter writer, RequestUserInput requestUserInput)
    {
        _writer = writer;
        _requestUserInput = requestUserInput;
    }

    public void ApplicationLaunchMessage(string message)
    {
        _writer.Clear();
        _writer.WriteLine(message);
    }

    public int RequestArrayLength(string message)
    {
        _writer.WriteLine(message);
        var arrayLength = _requestUserInput.GetIntegerInput();

        if (arrayLength < 1)
        {
            _writer.WriteLine(message);
            arrayLength = _requestUserInput.GetIntegerInput();
        }

        return arrayLength;
    }

    public int[] GetUserToPopulateArray(int arrayLength)
    {
        var arrayOfIntegers = new int[arrayLength];

        for (int i = 0; i < arrayLength; i++)
        {
            _writer.WriteLine($"Please type an integer in for the {i+1} element of the array: ");
            arrayOfIntegers[i] += _requestUserInput.GetIntegerInput();
        }

        return arrayOfIntegers;
    }
}