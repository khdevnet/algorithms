function Node(element) {
  this.element = element;
  this.next = null;
  this.prev = null;
}

function LinkedList() {
  this.head = null;
  this.tail = null;
  this.length = 0;
  this.toString = toString;
  this.remove = remove;
  this.insert = insert;
  this.isThereNode = isThereNode;
  this.clear = clear;
  this.pushFront = pushFront;
  this.pushBack = pushBack;
  this.popFront = popFront;
  this.popBack = popBack;
  this.getIndex = getIndex;
  this.getNode = getNode;
}

function getIndex(findNode) {
  var curNode = this.head;
  var result = -1;
  while (curNode !== findNode) {
    curNode = curNode.next;
    result++;
  }
  return result + 1;
}

function clear() {
  var curNode = this.head;
  while (curNode.next !== null) {
    curNode = curNode.next;
    delete curNode.prev;
  }
  this.head = null;
  this.tail = null;
  this.length = 0;
}

function toString() {
  var result;
  if (this.head !== null) {
    var curNode = this.head;
    result = "" + this.head.element + " ";
    while (curNode.next !== null) {
      result += curNode.next.element + " ";
      curNode = curNode.next;
    }
  } else {
    result = "empty";
  }

  return result;
}

function isThereNode(findNode) {
  var curNode = this.head;
  while (curNode.next !== null && curNode.next !== findNode) {
    curNode = curNode.next;
  }
  if (curNode.next === findNode) {
    return true;
  } else {
    return false;
  }
}

function remove(arg) {
  var delNode;
  if (arguments.length > 0 && this.isThereNode(arg)) {
    delNode = arg;
  } else if (arguments.length == 0) {
    var temp = this.getNode(this.length);
    if (temp) {
      temp.prev.next = null;
      delete temp;
    }
    return;
  } else {
    console.log("wrong arguments");
    return;
  }

  if (delNode !== this.head) {
    delNode.prev.next = delNode.next;
  }
  else {
    this.head = delNode.next;
  }

  if (delNode !== this.tail) {
    delNode.next.prev = delNode.prev;
  }
  else {
    this.tail = delNode.prev;
  }
  delete delNode;
  this.length--;
}

function getNode(index) {
  var resultNode = this.head;
  for (var loop = 0; loop < index; loop++) {
    resultNode = resultNode.next;
  }
  return resultNode;
}

function pushBack(data) {
  var insertNode;
  if (data instanceof Node) {
    insertNode = data;
  } else if (!(data instanceof Node)) {
    insertNode = new Node(data);
  } else {
    console.log("wrong arguments");
    return;
  }

  if (this.head === null) {
    this.head = insertNode;
    this.tail = this.head;
  }
  else {
    this.tail.next = insertNode;
    insertNode.prev = this.tail;
    this.tail = insertNode;
    this.length++;
  }
}

function pushFront(data) {
  var insertNode;
  if (data instanceof Node) {
    insertNode = data;
  } else if (!(data instanceof Node)) {
    insertNode = new Node(data);
  } else {
    console.log("wrong arguments");
    return;
  }

  if (this.head === null) {
    this.head = insertNode;
    this.tail = this.head;
  }
  else {
    this.head.prev = insertNode;
    insertNode.next = this.head;
    this.head = insertNode;
    this.length++;
  }
}

function popBack() {
  var delNode = this.tail;
  this.tail.prev.next = null;
  this.tail = this.tail.prev;
  delete delNode;
}

function popFront() {
  var delNode = this.head;
  this.head.next.prev = null;
  this.head = this.head.next;
  delete delNode;
}

function insert(data, position, LR) {
  var insertNode;
  var position;

  if (data instanceof Node) {
    if (this.head === null) {
      this.head = data;
      this.tail = this.head;
      this.length++;
      return;
    } else if (typeof position === "number" && position <= this.length - 1) {
      insertNode = data;
      position = this.getNode(position);
    }
    else if (position instanceof Node && this.isThereNode(position)) {
      insertNode = data;
      position = position;
    }
    else {
      console.log("wrong arguments");
      return;
    }
  }
  else if (!(data instanceof Node)) {
    if (this.head === null && position <= this.length - 1) {
      this.head = new Node(data);
      this.tail = this.head;
      this.length++;
      return;
    } else if (typeof position === "number" && position <= this.length - 1) {
      insertNode = new Node(data);
      position = this.getNode(position);
    }
    else if (position instanceof Node) {
      insertNode = new Node(data);
      position = position;
    }
    else {
      console.log("wrong arguments");
      return;
    }
  }

  if (LR === "L") {
    if (position !== this.head) {
      position.prev.next = insertNode;
    } else {
      this.head = insertNode;
    }
    insertNode.next = position;
    insertNode.prev = position.prev;
    position.prev = insertNode;
    this.length++;
  }
  else {
    if (position !== this.tail) {
      position.next.prev = insertNode;
    } else {
      this.tail = insertNode;
    }
    insertNode.next = position.next;
    insertNode.prev = position;
    position.next = insertNode;
    this.length++;
  }
}

module.exports = LinkedList;