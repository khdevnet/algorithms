var root = { name:"root", parent:null, children:[] };
var root11 = { name:"root1.1", parent:root, children:[] };
root11.children.push({ name:"root1.1.1", parent:root11, children:[] });
root.children.push(root11);
root.children.push({ name:"root1.2", parent:root, children:[] });

let q = [root];
while(q.length){
    let item = q.shift();
    console.log(item.name);
    if(item.children.length){
        q = [...q, ...item.children]
    }
}