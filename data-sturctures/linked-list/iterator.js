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
    },

    first: function () {
      this.reset();
      return this.next();
    },

    setList: function (theList) {
      this.list = theList;
      this.reset();
    },

    each: function (callback) {
      this.reset();
      var el;
      while (this.hasNext() && !this.stopIterationFlag) {
        el = this.next();
        callback(el);
      }
      this.stopIterationFlag = false;
    },

    last: function () {
      this.reset_reverse();
      return this.next_reverse();
    },

    reset_reverse: function () {
      this.currentNode = this.list.getTailNode();
    },

    next_reverse: function () {
      var current = this.currentNode;
      if (this.currentNode !== null) {
        this.currentNode = this.currentNode.prev;
      }

      return current;
    },

    each_reverse: function (callback) {
      this.reset_reverse();
      var el;
      while (this.hasNext() && !this.stopIterationFlag) {
        el = this.next_reverse();
        callback(el);
      }
      this.stopIterationFlag = false;
    },

    interrupt: function () {
      this.stopIterationFlag = true;
    }
  };

  module.exports = Iterator;

}());