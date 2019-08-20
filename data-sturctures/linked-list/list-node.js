(function () {
  'use strict';

  function Node(data) {
    this.data = data;
    this.next = null;
    this.prev = null;
  }

  Node.prototype = {
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