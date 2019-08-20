(function () {
  'use strict';

  function Node(data) {
    this.data = data;
    this.next = null;
    this.prev = null;
  }

  Node.prototype = {

    getData: function () {
      return this.data;
    },

    toString: function () {
      if (typeof this.data === 'object') {
        return JSON.stringify(this.data);
      } else {
        return String(this.data);
      }
    }
  };

  module.exports = Node;

}());