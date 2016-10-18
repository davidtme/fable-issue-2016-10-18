namespace Models

type TestModel = {
    Name: string
    Address : string
    Age : int
}

type FormModel<'a> = {
    Model : 'a
    Errors : Map<string, string> option
    ShowErrors : bool
}

type FormModelWrapper<'a, 'b> = {
    FormModel: FormModel<'a> option
    Id: 'b
}

type State = {
    StateText: string
    Test : FormModelWrapper<TestModel, int> option
}

type TestMessage<'a> =
    | Load of id:int
    | LoadError of id: int
    | Loaded of id:int * model:'a
    | Update of model:'a
    | Save

type Message =
    | Test of TestMessage<TestModel>