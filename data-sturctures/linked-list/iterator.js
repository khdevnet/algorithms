(function () {
  'use strict';

  function Iterator(theList) {
    this.list = theList || null;
    this.stopIterationFlag = false;

    this.currentNode = null;
  }

  Iterator.prototype = {

    next: function () {
      var current = this.currentNode;
      if (this.currentNode !== null) {
        this.currentNode = this.currentNode.next;
      }

      return current;
    },

    hasNext: function () {
      return this.currentNode !== null;
    },

    reset: function () {
      this.currentNode = this.list.getHeadNode();
    }
  };

  module.exports = Iterator;

}());