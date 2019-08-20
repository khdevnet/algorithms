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

  describe('clear', function () {
    it('should clear list', function () {
      var linkedList = new LinkedList();
      linkedList.insert(2);
      linkedList.insertFirst(3);

      linkedList.clear();
      assert.equal(linkedList.getSize(), 0);
    });
  });

  describe('insert', function () {
    it('should add element to the tail', function () {
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

  describe('insertBefore', function () {
    it('should add element before specified', function () {
      var linkedList = new LinkedList();
      linkedList.insert(2);
      linkedList.insert(3);
      linkedList.insertBefore(3, 4);
      let current = linkedList.find(4);
      assert.equal(current.prev, 2);
      assert.equal(current.next, 3);
    });

    it('should add element first', function () {
        var linkedList = new LinkedList();
        linkedList.insert(2);
        linkedList.insertBefore(2, 4);
        let current = linkedList.find(4);
        assert.equal(current.prev, null);
        assert.equal(current.next, 2);
      });

      it('shouldn"t add element, beacause not exist', function () {
        var linkedList = new LinkedList();
        linkedList.insert(2);
        linkedList.insert(3);
        assert.equal(linkedList.insertBefore(4, 4), false);
      });
  });

  describe('insertAfter', function () {
    it('should add element after specified', function () {
      var linkedList = new LinkedList();
      linkedList.insert(1);
      linkedList.insert(2);
      linkedList.insert(3);
      linkedList.insertAfter(2, 4);
      let current = linkedList.find(4);
      assert.equal(current.prev, 2);
      assert.equal(current.next, 3);
    });

    it('should add element last', function () {
        var linkedList = new LinkedList();
        linkedList.insert(2);
        linkedList.insert(3);
        linkedList.insertAfter(3, 4);
        let current = linkedList.find(4);
        assert.equal(current.prev, 3);
        assert.equal(current.next, null);
      });

      it('shouldn"t add element, beacause not exist', function () {
        var linkedList = new LinkedList();
        linkedList.insert(2);
        linkedList.insert(3);
        assert.equal(linkedList.insertAfter(4, 4), false);
      });
  });

  describe('remove', function () {
    it('should remove tail node', function () {
      var linkedList = new LinkedList();
      linkedList.insert(2);
      linkedList.insert(3);
      linkedList.insert(4);
      linkedList.remove();
      assert.equal(linkedList.find(4), null);
      assert.equal(linkedList.tail, 3);
    });
  });

  describe('removeFirst', function () {
    it('should remove head node', function () {
      var linkedList = new LinkedList();
      linkedList.insert(2);
      linkedList.insert(3);
      linkedList.insert(4);
      linkedList.removeFirst();
      assert.equal(linkedList.find(2), null);
      assert.equal(linkedList.head, 3);
    });
  });

  describe('removeNode', function () {
    it('should remove found node', function () {
      var linkedList = new LinkedList();
      linkedList.insert(2);
      linkedList.insert(3);
      linkedList.insert(4);
      linkedList.removeNode(3);

      assert.equal(linkedList.find(2).next, 4);
      assert.equal(linkedList.find(3), null);
      assert.equal(linkedList.find(4).prev, 2);
    });
  });

  describe('find', function () {
    it('should find node by data', function () {
      var linkedList = new LinkedList();
      linkedList.insert(2);
      linkedList.insert(3);
      linkedList.insert(4);
      let node = linkedList.find(3);
      assert.equal(node.data, 3);
    });
  });
});