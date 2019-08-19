var assert = require('assert');
var LinkedList = require('./linked-list');
describe('LinkedList', function() {
  describe('remove', function() {
    it('should add two elements', function() {
      var linkedList = new LinkedList();
      linkedList.pushFront(1);
      linkedList.pushFront(2);
      linkedList.pushFront(3);
      
      assert.equal(linkedList.length, 2);
    });
  });
});