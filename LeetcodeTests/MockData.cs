namespace LeetcodeTests
{
    public class MockData<TInput, TOutput>
    {
        public TInput Input { get; set; }
        public TOutput Output { get; set; }

        public MockData()
        {
            
        }

        public MockData(TInput input, TOutput output) 
        {
            this.Output = output;
            this.Input = input;
        }
    }

    public class MockData<TInput1, TInput2,  TOutput>
    {
        public TInput1 Input1 { get; set; }
        public TInput2 Input2 { get; set; }
        public TOutput Output { get; set; }

        public MockData()
        {

        }

        public MockData(TInput1 input1, TInput2 input2, TOutput output)
        {
            this.Output = output;
            this.Input1 = input1;
            this.Input2 = input2;
        }
    }
}
