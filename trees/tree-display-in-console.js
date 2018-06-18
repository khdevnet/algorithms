var root = { name:"root", parent:null, children:[] };
var root11 = { name:"root1.1", parent:root, children:[] };
root11.children.push({ name:"root1.1.1", parent:root11, children:[] });
root.children.push(root11);
root.children.push({ name:"root1.2", parent:root, children:[] });

function print(root){
    var printArr = [root];
    while(printArr.length){
        console.log(printArr.map(el=>el.name).join(" "));
        printArr = printArr.reduce((ac,el)=>{
            el.children.forEach(c=>ac.push(c));
            return ac;
        }, []);
      }
}

print(root);

