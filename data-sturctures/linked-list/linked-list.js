(function () {
    'use strict';

    var isEqual = require('./is-equal');
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
            var indexAndNode = this.indexAndNode(nodeData);

            if (!this.isIndexValid(indexAndNode.index)) {
                return false;
            }
            console.log(indexAndNode);
            if (indexAndNode.index === 0) {
                return this.insertFirst(dataToInsert);
            } else {
                return this.insertAt(indexAndNode.current, dataToInsert);
            }
        },

        insertAfter: function (nodeData, dataToInsert) {
            var indexAndNode = this.indexAndNode(nodeData);
            
            if (!this.isIndexValid(indexAndNode.index)) {
                return false;
            }

            var size = this.getSize();

            if (indexAndNode.index + 1 === size) {
                return this.insert(dataToInsert);
            } else {
                return this.insertAt(indexAndNode.current.next, dataToInsert);
            }
        },

        isIndexValid: function(index){
            return index >= 0 && index < this.getSize()
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

        removeAt: function (index) {
            var nodeToRemove = this.findAt(index);

            if (index < 0 || index > this.getSize() - 1) {
                return null;
            }

            if (index === 0) {
                return this.removeFirst();
            }

            if (index === this.getSize() - 1) {
                return this.remove();
            }

            nodeToRemove.prev.next = nodeToRemove.next;
            nodeToRemove.next.prev = nodeToRemove.prev;
            nodeToRemove.next = nodeToRemove.prev = null;

            this.size -= 1;

            return nodeToRemove;
        },

        removeNode: function (nodeData) {
            var index = this.indexOf(nodeData);
            return this.removeAt(index);
        },

        //################## FIND methods ####################

        indexOf: function (nodeData) {
            this.iterator.reset();
            var current;

            var index = 0;

            while (this.iterator.hasNext()) {
                current = this.iterator.next();
                if (isEqual(current.getData(), nodeData)) {
                    return index;
                }
                index += 1;
            }

            return -1;
        },

        indexAndNode: function (nodeData) {
            this.iterator.reset();
            var current;

            var index = 0;

            while (this.iterator.hasNext()) {
                current = this.iterator.next();
                if (isEqual(current.getData(), nodeData)) {
                    return { index, current};
                }
                index += 1;
            }

            return { index: -1, current: null};
        },

        find: function (nodeData) {
            this.iterator.reset();
            var current;

            while (this.iterator.hasNext()) {
                current = this.iterator.next();
                if (isEqual(current.getData(), nodeData)) {
                    return current;
                }
            }

            return -1;
        },

        findAt: function (index) {
            if (this.isEmpty() || index > this.getSize() - 1) {
                return -1;
            }

            var node = this.getHeadNode();
            var position = 0;

            while (position < index) {
                node = node.next;
                position += 1;
            }

            return node;
        },

        //################## UTILITY methods ####################

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