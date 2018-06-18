var root = { name: "root", parent: null, children: [] };
var root11 = { name: "root1.1", parent: root, children: [] };
root11.children.push({ name: "root1.1.1", parent: root11, children: [] });
root.children.push(root11);
root.children.push({ name: "root1.2", parent: root, children: [] });

depthFirstLiner(root);
depthFirstRec(root);

function depthFirstLiner(node) {
    let q = [node];
    while (q.length) {
        let item = q.pop();
        console.log(item.name);
        if (item.children.length) {
            q = [...q, ...item.children]
        }
    }
}


function depthFirstRec(node) {
    console.log(node.name);
    if (node.children.length) {
        node.children.forEach(element => {
            depthFirstRec(element);
        });
    }
}