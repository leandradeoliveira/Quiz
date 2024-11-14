using Exercicio;
Tree tree= new Tree();

tree.Root = new Node(){
    Data = new Person(){Name = "Marcin Jamro",Role = "CEO"}
};

tree.Root.Children = new List<Node>(){
    new Node(){Data = new Person (){Name = "John Smith", Role="Head of Develpment"}, Parent = tree.Root},
    new Node(){Data = new Person (){Name = "Mary Fox", Role="Head of Research"}, Parent = tree.Root},
    new Node(){Data = new Person (){Name = "Lily Smith", Role="Head of Sales"}, Parent = tree.Root}
};

tree.Root.Children[0].Children = new List<Node>(){ // Jonh Smith
    new Node(){Data = new Person (){Name = "Chris Morris", Role="Senior Develpment"}, Parent = tree.Root.Children[0]}
};

tree.Root.Children[0].Children[0].Children = new List<Node>(){ // Chris Morris
    new Node(){Data = new Person (){Name = "Eric Green", Role="Junior Develpment"}, Parent = tree.Root.Children[0].Children[0]},
    new Node(){Data = new Person (){Name = "Ashley Lopez", Role="Junior Develpment"}, Parent = tree.Root.Children[0].Children[0]}
};
tree.Root.Children[0].Children[0].Children[1].Children = new List<Node>(){// Ashley Lopes
    new Node(){Data = new Person (){Name = "Emily Young", Role="Developer Intern"}, Parent = tree.Root.Children[0].Children[0].Children[1]}
};

tree.Root.Children[1].Children = new List<Node>(){ //Mary fox
    new Node(){Data = new Person (){Name = "Jimmy Stewart", Role="Senior Researcher"}, Parent = tree.Root.Children[1]},
    new Node(){Data = new Person (){Name = "Andy Wood", Role="Senior Researcher"}, Parent = tree.Root.Children[1]}
};

tree.Root.Children[2].Children = new List<Node>(){//Lily Smith
    new Node(){Data = new Person (){Name = "Anthony Black", Role="Senior Sales Specialist"}, Parent = tree.Root.Children[2]},
    new Node(){Data = new Person (){Name = "Angela Evans", Role="Senior Sales Specialist"}, Parent = tree.Root.Children[2]},
    new Node(){Data = new Person (){Name = "Tommy Butler", Role="Senior Account Manager"}, Parent = tree.Root.Children[2]}
};
tree.Root.Children[2].Children[0].Children =  new List<Node>(){
    new Node() {Data = new Person (){Name = "Paula Scott", Role = "Junior Sales Specialist"}, Parent = tree.Root.Children[2].Children[0]},
    new Node() {Data = new Person (){Name = "Sarah Watson", Role = "Junior Sales Specialist"}, Parent = tree.Root.Children[2].Children[0]},
};

tree.PrintTree(tree.Root);