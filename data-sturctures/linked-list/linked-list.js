(function () {
    'use strict';

    var Node = require('./list-node');
    var Iterator = require('./iterator');

    function LinkedList() {
        this.head = null;
        this.tail = null;
        this.size = 0;

        this.iterator = new Iterator(this);
    }

    LinkedList.prototype = {

        createNewNode: function (data) {
            return new Node(data);
        },

        getHeadNode: function () {
            return this.head;
        },

        getTailNode: function () {
            return this.tail;
        },

        isEmpty: function () {
            return (this.size === 0);
        },

        getSize: function () {
            return this.size;
        },

        clear: function () {
            while (!this.isEmpty()) {
                this.remove();
            }
        },

        insert: function (data) {
            var newNode = this.createNewNode(data);
            if (this.isEmpty()) {
                this.head = this.tail = newNode;
            } else {
                this.tail.next = newNode;
                newNode.prev = this.tail;
                this.tail = newNode;
            }
            this.size += 1;

            return true;
        },

        insertFirst: function (data) {
            if (this.isEmpty()) {
                this.insert(data);
            } else {
                var newNode = this.createNewNode(data);

                newNode.next = this.head;
                this.head.prev = newNode;
                this.head = newNode;

                this.size += 1;
            }

            return true;
        },

        insertAt: function (current, data) {
            var newNode = this.createNewNode(data);

            current.prev.next = newNode;
            newNode.prev = current.prev;
            current.prev = newNode;
            newNode.next = current;

            this.size += 1;

            return true;
        },

        insertBefore: function (nodeData, dataToInsert) {
            var current = this.find(nodeData);

            if (!current) {
                return false;
            }

            if (!current.prev) {
                return this.insertFirst(dataToInsert);
            } else {
                return this.insertAt(current, dataToInsert);
            }
        },

        insertAfter: function (nodeData, dataToInsert) {
            var current = this.find(nodeData);

            if (!current) {
                return false;
            }

            if (!current.next) {
                return this.insert(dataToInsert);
            } else {
                return this.insertAt(current.next, dataToInsert);
            }
        },

        remove: function () {
            if (this.isEmpty()) {
                return null;
            }

            var nodeToRemove = this.getTailNode();

            if (this.getSize() === 1) {
                this.head = null;
                this.tail = null;
            } else {
                this.tail = this.getTailNode().prev;
                this.tail.next = null;
            }
            this.size -= 1;

            return nodeToRemove;
        },

        removeFirst: function () {
            if (this.isEmpty()) {
                return null;
            }

            var nodeToRemove;

            if (this.getSize() === 1) {
                nodeToRemove = this.remove();
            } else {
                nodeToRemove = this.getHeadNode();
                this.head = this.head.next;
                this.head.prev = null;
                this.size -= 1;
            }

            return nodeToRemove;
        },

        removeAt: function (nodeToRemove) {
            nodeToRemove.prev.next = nodeToRemove.next;
            nodeToRemove.next.prev = nodeToRemove.prev;
            nodeToRemove.next = nodeToRemove.prev = null;

            this.size -= 1;

            return nodeToRemove;
        },

        removeNode: function (nodeData) {
            var current = this.find(nodeData);

            if (!current) {
                return false;
            }

            if (!current.prev) {
                return this.removeFirst();
            } else if (!current.next) {
                return this.remove();
            } else {
                return this.removeAt(current);
            }
        },

        //################## FIND methods ####################

        find: function (nodeData) {
            this.iterator.reset();
            var current;

            while (this.iterator.hasNext()) {
                current = this.iterator.next();
                if (current.getData() === nodeData) {
                    return current;
                }
            }

            return null;
        },

        forEach: function (fn, reverse) {
            reverse = reverse || false;
            if (reverse) {
                this.iterator.reset_reverse();
                this.iterator.each_reverse(fn);
            } else {
                this.iterator.reset();
                this.iterator.each(fn);
            }
        },

        toArray: function () {
            var listArray = [];
            this.forEach(function (node) {
                listArray.push(node.getData());
            });

            return listArray;
        }
    };

    module.exports = LinkedList;

}());