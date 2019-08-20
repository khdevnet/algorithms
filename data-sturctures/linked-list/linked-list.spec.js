var assert = require('assert');
var LinkedList = require('./linked-list');
describe('LinkedList', function () {

  describe('getHeadNode', function () {
    it('should return the head node', function () {
      var linkedList = new LinkedList();
      linkedList.insert(2);
      linkedList.insertFirst(3);

      assert.equal(linkedList.getHeadNode(), 3);
    });
  });

  describe('getTailNode', function () {
    it('should return the head node', function () {
      var linkedList = new LinkedList();
      linkedList.insert(2);
      linkedList.insertFirst(3);

      assert.equal(linkedList.getTailNode(), 2);
    });
  });

  describe('insert', function () {
    it('should add second element to the tail', function () {
      var linkedList = new LinkedList();
      linkedList.insert(2);
      linkedList.insert(3);

      assert.equal(linkedList.tail, 3);
    });

    it('should add first element to the head and tail', function () {
      var linkedList = new LinkedList();
      linkedList.insert(2);

      assert.equal(linkedList.head, 2);
      assert.equal(linkedList.tail, 2);
    });
  });

  describe('insertFirst', function () {
    it('should add element to the head', function () {
      var linkedList = new LinkedList();
      linkedList.insert(2);
      linkedList.insertFirst(3);

      assert.equal(linkedList.head, 3);
    });
  });

  describe('insertAfter', function () {
    it('should add element after specified', function () {
      var linkedList = new LinkedList();
      linkedList.insert(2);
      linkedList.insert(3);
      linkedList.insertAfter(2, 4);
      let current = linkedList.find(4);
      assert.equal(current.prev, 2);
    });
  });

  describe('insertBefore', function () {
    it('should add element before specified', function () {
      var linkedList = new LinkedList();
      linkedList.insert(2);
      linkedList.insert(3);
      linkedList.insertBefore(3, 4);
      let current = linkedList.find(4);
      assert.equal(current.next, 3);
    });
  });
});